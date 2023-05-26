import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { RestApiService } from 'src/app/services/restApi/restApi.service';
import { DialogProjectComponent } from '../modal/dialog-project/dialog-project.component';
import { Observable, map, tap } from 'rxjs';
import { v4 as uuidv4 } from 'uuid';
import { ITasks } from 'src/app/models/Tasks';
import { ActivatedRoute } from '@angular/router';
import { ITasksVM } from 'src/app/models/TasksVM';
import { DialogTasksComponent } from '../modal/dialog-tasks/dialog-tasks.component';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss'],
})
export class TasksComponent implements OnInit {
  TasksList: ITasks[] = [];
  projectId: string = '';
  projectName: string = '';

  dataLoaded = false; // Флаг, указывающий на загрузку данных

  tasks: ITasks = {
    id: '',
    tasksName: '',
    projectId: '',
    startDate: new Date(),
    cancelDate: new Date(),
    createDate: new Date(),
    updateDate: new Date(),
  };

  constructor(
    private restApiService: RestApiService,
    public dialog: MatDialog,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.projectId = params['id']; // Здесь получаем значение параметра
      this.getAllTasks(this.projectId);
    });

  }

  getAllTasks(projectId:string){
    this.restApiService
    .getAllItemsList<ITasksVM>('Tasks/GetAllFromProject/' + projectId)
    .subscribe((list: ITasksVM[]) => {
      this.TasksList = list;
      this.dataLoaded = true;
      this.projectName = list[0].project.projectName;
    });
  }

  addTasks(tasksName: string, projectId: string) {
    if (this.tasks != null) {
      this.tasks.id = uuidv4();
      this.tasks.tasksName = tasksName;
      this.tasks.projectId = projectId;
      this.tasks.createDate = new Date();
      this.tasks.updateDate = new Date();
      this.tasks.cancelDate = new Date(+0);
      this.tasks.startDate = new Date();

      this.restApiService
        .addValue<ITasks>(this.tasks, 'Tasks/Create')
        .pipe(
          tap(() => {
            this.TasksList = [...this.TasksList, this.tasks];
          })
        )
        .subscribe();
    }
  }

  delTasks(id: string) {
    this.restApiService
      .removeValue<ITasks>(id, 'Tasks/Delete?id=')
      .pipe(
        tap(
          () =>
            (this.TasksList = this.TasksList.filter(
              (item: ITasks) => item.id !== id
            ))
        )
      )
      .subscribe();
  }

  getTasks(id: string): Observable<ITasks> {
    return this.restApiService.getValue('Tasks/Get/' + id).pipe(
      map((data: any) => {
        const tasks: ITasks = {
          id: data.id,
          tasksName: data.tasksName,
          projectId: data.projectId,
          createDate: new Date(data.createDate),
          updateDate: new Date(data.updateDate),
          startDate: new Date(data.startDate),
          cancelDate: new Date(data.cancelDate),
        };
        return tasks;
      })
    );
  }

  openDialogAddTasks(): void {
    let dialogRef = this.dialog.open(DialogTasksComponent, {
      width: '350px',
      data: {},
    });
    dialogRef.afterClosed().subscribe((result) => {
      if (result != undefined) {
        this.addTasks(result.form.tasksName, result.form.projectId);
      }
    });
  }

  openDialogEditProject(id: string): void {
    this.getTasks(id).subscribe((tasks) => {
      let dialogRef = this.dialog.open(DialogTasksComponent, {
        width: '350px',
        data: { tasks: tasks },
      });
      dialogRef.afterClosed().subscribe((result) => {
        if (result != undefined) {
          tasks.tasksName = result.form.projectName;
          tasks.updateDate = new Date();

          this.restApiService
            .editValue<ITasks>(tasks, 'Tasks/Update')
            .subscribe(() => {
              const updatedProjectList = this.TasksList.map((item) => {
                if (item.id === tasks.id) {
                  return tasks;
                }
                return item;
              });
              this.TasksList = [...updatedProjectList];
            });
        }
      });
    });
  }
}
