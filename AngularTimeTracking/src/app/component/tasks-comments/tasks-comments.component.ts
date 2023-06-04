import { Component, NgModule, OnInit, ViewChild } from '@angular/core';
import { ITasksComments } from 'src/app/models/TasksComments';
import { RestApiService } from 'src/app/services/restApi/restApi.service';
import { DialogProjectComponent } from '../modal/dialog-project/dialog-project.component';
import { Observable, map, tap } from 'rxjs';
import { v4 as uuidv4 } from 'uuid';
import { DialogProjectEditComponent } from '../modal/dialog-project-edit/dialog-project-edit.component';
import { MatMenuTrigger } from '@angular/material/menu';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DialogCommentsComponent } from '../modal/dialog-comments/dialog-comments.component';

@Component({
  selector: 'app-tasks-comments',
  templateUrl: './tasks-comments.component.html',
  styleUrls: ['./tasks-comments.component.scss'],
})
export class TasksCommentsComponent implements OnInit {
  constructor(
    private restApiService: RestApiService,
    public dialog: MatDialog,
    private route: ActivatedRoute
  ) {}

  TasksComments: ITasksComments[] = [];

  file: Blob | undefined;
  commentDescription: string | null = null;
  dataLoaded = false; // Флаг, указывающий на загрузку данных\
  tasksId: string = '';

  taskComment: ITasksComments = {
    id: '',
    tasksId: '',
    commentType: 0,
    content: null,
  };

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.tasksId = params['id'];
      this.getAllTasksComment(this.tasksId);
    });
  }

  addTasksCommen(
    tasksId: string,
    tasksDescriptions: string | null,
    file: Blob | null
  ) {
    this.taskComment.id = uuidv4();
    this.taskComment.commentType = 0;
    this.taskComment.tasksId = tasksId;
    if (file) {
      const reader = new FileReader();
      reader.onloadend = () => {
        const byteArray = new Uint8Array(reader.result as ArrayBuffer);
        this.taskComment.content =  Array.from(byteArray);;
        this.addTasksCommenGet()
      };
      reader.readAsArrayBuffer(file);
    } else {
      if (tasksDescriptions) {
        const encoder = new TextEncoder();
        const encodedData = encoder.encode(tasksDescriptions);
        this.taskComment.content = Array.from(encodedData);
        this.addTasksCommenGet()
      }
    }
  }

  addTasksCommenGet() {
    this.restApiService
      .addValue<ITasksComments>(this.taskComment, 'TasksComments/Create')
      .pipe(
        tap(() => {
          this.TasksComments = [...this.TasksComments, this.taskComment];
        })
      )
      .subscribe();
  }

  delTasksComments(id: string) {
    this.restApiService
      .removeValue<ITasksComments>(id, 'TasksComments/Delete?id=')
      .pipe(
        tap(
          () =>
            (this.TasksComments = this.TasksComments.filter(
              (item: ITasksComments) => item.id !== id
            ))
        )
      )
      .subscribe();
  }

  getAllTasksComment(id: string) {
    this.restApiService
      .getAllItemsList<ITasksComments>('TasksComments/GetAllFromTasks/' + id)
      .subscribe((list: ITasksComments[]) => {
        this.dataLoaded = true;
        this.TasksComments = list;
      });
  }

  openDialogAddComponent(): void {
    let dialogRef = this.dialog.open(DialogCommentsComponent, {
      width: '350px',
      data: {},
    });
    dialogRef.afterClosed().subscribe((result) => {
      if (result != undefined) {
        this.addTasksCommen(
          this.tasksId,
          result.form.commentDescription,
          result.file as Blob
        );
      }
    });
  }

  // openDialogEditProject(id: string): void {
  //   this.getProject(id).subscribe((project) => {
  //     let dialogRef = this.dialog.open(DialogProjectEditComponent, {
  //       width: '350px',
  //       data: { project: project },
  //     });
  //     dialogRef.afterClosed().subscribe((result) => {
  //       if (result != undefined) {
  //         project.projectName = result.form.projectName;
  //         project.updateDate = new Date();
  //         this.restApiService
  //           .editValue<IProject>(project, 'Project/Update')
  //           .subscribe(() => {
  //             const updatedProjectList = this.ProjectList.map((item) => {
  //               if (item.id === project.id) {
  //                 return project;
  //               }
  //               return item;
  //             });
  //             this.ProjectList = [...updatedProjectList];
  //           });
  //       }
  //     });
  //   });
  // }
}
