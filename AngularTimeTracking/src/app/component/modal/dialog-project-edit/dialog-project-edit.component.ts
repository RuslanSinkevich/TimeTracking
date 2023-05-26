import { Component, Inject  } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IProject } from 'src/app/models/project';

@Component({
  selector: 'app-dialog-project-edit',
  templateUrl: './dialog-project-edit.component.html',
  styleUrls: ['./dialog-project-edit.component.scss']
})
export class DialogProjectEditComponent {
  form: FormGroup;


  constructor(public  dialogRef: MatDialogRef<DialogProjectEditComponent>,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: { project: IProject }) {
    this.form = this.fb.group({
      projectName: [data.project.projectName, Validators.required],
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
