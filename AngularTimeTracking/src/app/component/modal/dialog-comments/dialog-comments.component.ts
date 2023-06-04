import { Component, Inject  } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-dialog-comments',
  templateUrl: './dialog-comments.component.html',
  styleUrls: ['./dialog-comments.component.scss']
})
export class DialogCommentsComponent {
  form: FormGroup;
  file: File | undefined;
  isTextAreaSelected  = false;

  constructor(public  dialogRef: MatDialogRef<DialogCommentsComponent>,
    private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: {}) {

    this.form = this.fb.group({
      commentDescription: '',
      content: '',
    });
  }

  submit() {
    if (this.form.valid) {
      this.dialogRef.close({
        clicked: 'submit',
        form: this.form.value,
        file: this.file
      });
    }
  }

  onFileSelected(event: any): void {
    this.file = event.target.files.length > 0 ? event.target.files[0] : null;
  }

}

