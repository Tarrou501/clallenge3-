import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Cliente } from '../cliente.model';
import { ClienteService } from '../cliente.service';

@Component({
  selector: 'app-cliente-delete',
  templateUrl: './cliente-delete.component.html',
  styleUrls: ['./cliente-delete.component.css']
})
export class ClienteDeleteComponent implements OnInit {

  cliente: Cliente = {
    id:0,
    nome: '',
    sobreNome: '',
    cpf: '',
    dataNasc: '',
    idade:0,
    profissao: 0
  }

  constructor(private clienteService: ClienteService,
    private router: Router,
    private route: ActivatedRoute) { }


  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.clienteService.readById(id ?? "0").subscribe(
      resp => this.cliente = resp
    );
  }

  deleteCliente(): void {
    this.clienteService.delete(this.cliente.id).subscribe(() => {
      this.clienteService.showMessage('Cliente excluído com sucesso!')
      this.router.navigate(['/clientes']);
    });
  }

  cancel() {
    this.router.navigate(['/clientes']);
  }

}
