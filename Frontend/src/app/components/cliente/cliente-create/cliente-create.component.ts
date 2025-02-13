import { ClienteService } from './../cliente.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cliente } from '../cliente.model';
import { NgCpfModule } from 'ngcpf';

@Component({
  selector: 'app-cliente-create',
  templateUrl: './cliente-create.component.html',
  styleUrls: ['./cliente-create.component.css']
})
export class ClienteCreateComponent implements OnInit {

  cliente: Cliente = {
    id:0, 
    nome:'',
     sobreNome:'',
     cpf:'',
     dataNasc:'' ,
     idade:0,
     profissao: 0 
  }
  
  constructor(private clienteService: ClienteService,
    private router:Router) { }

  ngOnInit(): void {
    
  }

  createCliente():void{

    this.clienteService.create(this.cliente).subscribe(() =>{
      this.clienteService.showMessage('Cliente criado!');
      this.router.navigate(['/clientes']);
    })

  }
  cancel():void{
    this.router.navigate(['/clientes']);
  }
}
