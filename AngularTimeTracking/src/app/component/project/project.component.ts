import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { IProject } from 'src/app/models/project';
import { RestApiService } from 'src/app/services/restApi/restApi.service';
import { DialogProjectComponent } from '../modal/dialog-project/dialog-project.component';
import { Observable, map, tap } from 'rxjs';
import { v4 as uuidv4 } from 'uuid';
import { DialogProjectEditComponent } from '../modal/dialog-project-edit/dialog-project-edit.component';
import {MatMenuTrigger} from '@angular/material/menu';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.scss'],
})

export class ProjectComponent implements OnInit {
  @ViewChild('menuPTrigger') menuPTrigger: MatMenuTrigger | undefined;

  ProjectList: IProject[] = [];

  dataLoaded = false; // Флаг, указывающий на загрузку данных
  Project: IProject = {
    id: '',
    projectName: '',
    updateDate: new Date(),
    createDate: new Date(),
  };

  constructor(
    private restApiService: RestApiService,
    public dialog: MatDialog,
  ) {}

  ngOnInit() {
    this.restApiService
      .getAllItemsList<IProject>('Project/GetAll')
      .subscribe((list:IProject[]) => {
        setTimeout(() => {
          // Тестовая задержка запроса
          this.ProjectList = list;
          this.dataLoaded = true;
        }, 200);
      });
  }

  addProject(projectName: string) {
    if (projectName != null) {
      this.Project.id = uuidv4();
      this.Project.projectName = projectName;
      this.Project.createDate = new Date();
      this.Project.updateDate = new Date();

      this.restApiService
        .addValue<IProject>(this.Project, 'Project/Create')
        .pipe(
          tap(() => {
            this.ProjectList = [...this.ProjectList, this.Project];
          })
        )
        .subscribe();
    }
  }

  delProject(id: string) {
    this.restApiService
      .removeValue<IProject>(id, 'Project/Delete?id=')
      .pipe(
        tap(
          () =>
            (this.ProjectList = this.ProjectList.filter(
              (item: IProject) => item.id !== id
            ))
        )
      )
      .subscribe();
  }

  getProject(id: string): Observable<IProject> {
    return this.restApiService.getValue('Project/Get/' + id).pipe(
      map((data: any) => {
        const project: IProject = {
          id: data.id,
          projectName: data.projectName,
          createDate: new Date(data.createDate),
          updateDate: new Date(data.updateDate),
        };
        return project;
      })
    );
  }

  openDialogAddProject(): void {
    let dialogRef = this.dialog.open(DialogProjectComponent, {
      width: '350px',
      data: { },
    });
    dialogRef.afterClosed().subscribe((result) => {
      if (result != undefined) {
        this.addProject(result.form.projectName);
      }
    });
  }

  openDialogEditProject(id: string): void {
    console.log(id);

    this.getProject(id).subscribe((project) => {
      let dialogRef = this.dialog.open(DialogProjectEditComponent, {
        width: '350px',
        data: { project: project },
      });
      dialogRef.afterClosed().subscribe((result) => {
        if (result != undefined) {
          project.projectName = result.form.projectName;
          project.updateDate = new Date();
          this.restApiService
            .editValue<IProject>(project, 'Project/Update')
            .subscribe(() => {
              const updatedProjectList = this.ProjectList.map((item) => {
                if (item.id === project.id) {
                  return project;
                }
                return item;
              });
              this.ProjectList = [...updatedProjectList];
            });
        }
      });
    });
  }
}
