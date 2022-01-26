import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {MatSnackBar} from '@angular/material/snack-bar';
import { Observable } from 'rxjs';
import { Cliente } from './cliente.model';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  baseUrl = "https://localhost:44362/api/cliente";

  constructor(private snackBar:MatSnackBar, private http: HttpClient) { }

  showMessage(msg:string):void{
    this.snackBar.open(msg,'X',{
      duration:3000,
      horizontalPosition:"right",
      verticalPosition:"top"
    });
  }
  
  create(cliente: Cliente): Observable<Cliente>{
    console.log(cliente);
     return this.http.post<Cliente>(this.baseUrl,cliente);  

  }

  read(): Observable<Cliente[]>{
    return this.http.get<Cliente[]>(this.baseUrl);   
  }

  readById(id:string): Observable<Cliente>{
    const url = `${this.baseUrl}/${id}`;
    return this.http.get<Cliente>(url);   
  }

  update(cliente: Cliente): Observable<Cliente>{
    //const url = `${this.baseUrl}/${cliente.id}`;

    return  this.http.put<Cliente>(this.baseUrl,cliente);   
  }

}
