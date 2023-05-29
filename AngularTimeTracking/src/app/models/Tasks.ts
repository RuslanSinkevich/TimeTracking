export interface ITasks{
  id: string,
  tasksName: string,
  projectId: string,
  startDate: Date,
  cancelDate: Date | undefined,
  createDate: Date,
  updateDate: Date
}
