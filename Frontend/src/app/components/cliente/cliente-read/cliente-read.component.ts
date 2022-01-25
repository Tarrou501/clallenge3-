import { Component, OnInit } from '@angular/core';
import { Cliente } from '../cliente.model';
import { ClienteService } from '../cliente.service';

@Component({
  selector: 'app-cliente-read',
  templateUrl: './cliente-read.component.html',
  styleUrls: ['./cliente-read.component.css']
})
export class ClienteReadComponent implements OnInit {

  clientes: Cliente[]
  displayedColumns = ['id','nome','sobrenome','cpf','datanasc','idade','profissao','action']
  
  constructor(private clienteService: ClienteService) {
    this.clientes=[];
   }

  ngOnInit(): void {

    console.log("oi cliente-read");
    this.clienteService.read().subscribe(clientes =>{
        this.clientes = clientes;
        console.log(clientes);
    })
  }

}
