import { Data } from "@angular/router";

export interface ITasks{
  id: string,
  tasksName: string,
  projectId: string,
  startDate: Date,
  cancelDate: Date,
  createDate: Date,
  updateDate: Date
}
