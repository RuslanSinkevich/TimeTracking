import { Component, Inject  } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { DialogProjectComponent } from '../dialog-project/dialog-project.component';
import { ITasks } from 'src/app/models/Tasks';

@Component({
  selector: 'app-dialog-tasks',
  templateUrl: './dialog-tasks.component.html',
  styleUrls: ['./dialog-tasks.component.css']
})
export class DialogTasksComponent {
  form: FormGroup;

  constructor(public  dialogRef: MatDialogRef<DialogTasksComponent>,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: { tasks: ITasks, nameComp: string}) {

    this.form = this.fb.group({
      tasksName: ['', Validators.required],
    });
  }

  submit() {
    if (this.form.valid) {
      this.dialogRef.close({
        clicked: 'submit',
        form: this.form.value
      });
    }
  }

}
