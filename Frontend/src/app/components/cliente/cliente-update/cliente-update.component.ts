import { ActivatedRoute, Router } from '@angular/router';
import { ClienteService } from './../cliente.service';
import { Component, OnInit } from '@angular/core';
import { Cliente } from '../cliente.model';

@Component({
  selector: 'app-cliente-update',
  templateUrl: './cliente-update.component.html',
  styleUrls: ['./cliente-update.component.css']
})
export class ClienteUpdateComponent implements OnInit {

  cliente: Cliente = {
    nome:'',
    sobreNome:'',
    cpf:'',
    dataNasc:'' ,
    profissao: 0 
 }
 
  constructor(private clienteService: ClienteService,
     private router: Router,
     private route: ActivatedRoute) { }

 
  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.clienteService.readById(id??"0").subscribe(
           resp => this.cliente = resp
    );
    

  }

  updateCliente(): void {
      this.clienteService.update(this.cliente).subscribe(()=>{
      this.clienteService.showMessage('Cliente atualizado com sucesso');
      this.router.navigate(['/clientes']);
      });
  }

  cancel(): void {
    this.router.navigate(['/clientes'])
  }
}
