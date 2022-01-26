import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { catchError, EMPTY, map, Observable } from 'rxjs';
import { Cliente } from './cliente.model';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  baseUrl = "https://localhost:44362/api/cliente";

  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string, isError: boolean = false): void {
    this.snackBar.open(msg, 'X', {
      duration: 3000,
      horizontalPosition: "right",
      verticalPosition: "top",
      panelClass: isError ? ['msg-error'] : ['msg-success']
      // panelClass: 'notif-success'
    });
  }

  create(cliente: Cliente): Observable<Cliente> {
    console.log(cliente);
    return this.http.post<Cliente>(this.baseUrl, cliente).pipe(
      map(obj => obj),
      catchError(e => this.ErrorHandlee(e))
    );

  }

  ErrorHandlee(e: any): Observable<any> {
    this.showMessage('Ocorreu um erro!', true);
    return EMPTY;
  }

  read(): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(this.baseUrl).pipe(
      map(obj => obj),
      catchError(e => this.ErrorHandlee(e))
    );
  }

  readById(id: string): Observable<Cliente> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.get<Cliente>(url).pipe(
      map(obj => obj),
      catchError(e => this.ErrorHandlee(e))
    );
  }

  update(cliente: Cliente): Observable<Cliente> {
    //const url = `${this.baseUrl}/${cliente.id}`;

    return this.http.put<Cliente>(this.baseUrl, cliente).pipe(
      map(obj => obj),
      catchError(e => this.ErrorHandlee(e))
    );
  }

  delete(id: number): Observable<Cliente> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.delete<Cliente>(url).pipe(
      map(obj => obj),
      catchError(e => this.ErrorHandlee(e))
    );
  }
}
