import { Component, Inject  } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IProject } from 'src/app/models/project';

@Component({
  selector: 'app-dialog-project',
  templateUrl: './dialog-project.component.html',
  styleUrls: ['./dialog-project.component.scss']
})
export class DialogProjectComponent {
  form: FormGroup;

  constructor(public  dialogRef: MatDialogRef<DialogProjectComponent>,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: { project: IProject, nameComp: string}) {

    this.form = this.fb.group({
      projectName: ['', Validators.required],
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
