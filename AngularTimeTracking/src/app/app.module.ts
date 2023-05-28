import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ProjectComponent } from './component/project/project.component';
import { NgxDatatableModule } from '@swimlane/ngx-datatable';
import { MenuVerticalComponent } from './component/template/menu-vertically/menu-vertical.component';
import { MainComponent } from './component/template/main/main.component';
import { GlobalErrorComponent } from './component/shared/global-error/global-error.component';
import { TasksComponent } from './component/tasks/tasks.component';
import { RouterModule, Routes } from '@angular/router';
import { LoadComponent } from './component/shared/load/load.component';
import { MatButtonModule} from '@angular/material/button';
import { MatDialogModule} from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { MatMenuModule } from '@angular/material/menu';
import { DialogProjectComponent } from './component/modal/dialog-project/dialog-project.component';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatNativeDateModule, NativeDateAdapter, DateAdapter  } from '@angular/material/core';
import { DialogProjectEditComponent } from './component/modal/dialog-project-edit/dialog-project-edit.component';
import {MatSelectModule} from '@angular/material/select';
import { LOCALE_ID } from '@angular/core';
import { registerLocaleData } from '@angular/common';
import localeRu from '@angular/common/locales/ru';

const routes: Routes = [
  {
    path: '',
    children: [
      { path: '', redirectTo: 'project', pathMatch: 'full' },
      { path: 'project', component: ProjectComponent },
      { path: 'tasks', component: TasksComponent },
      { path: 'tasks/:id', component: TasksComponent },
    ]
  }
];

registerLocaleData(localeRu);

@NgModule({
  declarations: [
    AppComponent,
    ProjectComponent,
    MenuVerticalComponent,
    MainComponent,
    GlobalErrorComponent,
    TasksComponent,
    LoadComponent,
    DialogProjectComponent,
    DialogProjectEditComponent,
  ],
  imports: [
    BrowserModule,
    NgxDatatableModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatMenuModule,
    MatSelectModule

  ],
  providers: [{ provide: DateAdapter, useClass: NativeDateAdapter },
    { provide: LOCALE_ID, useValue: 'ru' }
],
  bootstrap: [AppComponent]
})
export class AppModule { }
