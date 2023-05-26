import { Data } from "@angular/router";

export interface ITasksVM{
  id: string,
  tasksName: string,
  projectId: string,
  project: {
    id: string,
    projectName: string,
    createDate: Date,
    updateDate: Date
 },
  startDate: Date,
  cancelDate: Date,
  createDate: Date,
  updateDate: Date
}
