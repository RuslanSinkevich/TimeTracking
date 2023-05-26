import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ErrorService } from '../error.service';
import { API_URL } from 'src/app/utility/constants';
import { IProject } from 'src/app/models/project';
import { catchError, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RestApiService {
  path: string = API_URL;

  constructor(private http: HttpClient, private errorService: ErrorService) {}

  // Generic type
  getAllItemsList<T>(url: string) {
    return this.http
      .get<T[]>(this.path + url)
      .pipe(catchError(this.handleError.bind(this)));
  }

  getValue<T>(url: string) {
    return this.http
      .get(this.path + url)
      .pipe(catchError(this.handleError.bind(this)));
  }

  addValue<T>(Value: T, url: string) {
    return this.http
      .post(this.path + url, Value)
      .pipe(catchError(this.handleError.bind(this)));
  }

  editValue<T>(Value: T, url: string) {
    return this.http
      .put(this.path + url, Value)
      .pipe(catchError(this.handleError.bind(this)));
  }

  removeValue<T>(idValue: string, url: string) {
    return this.http
      .delete(this.path + url + idValue)
      .pipe(catchError(this.handleError.bind(this)));
  }

  private handleError(error: HttpErrorResponse) {
    this.errorService.handle(error.message);
    return throwError(() => error.message);
  }
}
