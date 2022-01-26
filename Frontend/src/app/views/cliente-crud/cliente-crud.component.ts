import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-cliente-crud',
  templateUrl: './cliente-crud.component.html',
  styleUrls: ['./cliente-crud.component.css']
})
export class ClienteCrudComponent implements OnInit {

  constructor(private router:Router,private headerService:HeaderService) {   
    headerService.headerData ={
      title: 'Cadastro de Cliente',
      icon:'storefront',
      routeUrl: '/clientes'
    }
  }

  ngOnInit(): void {
  }
  navigateToClienteCreate():void{
    this.router.navigate(['/clientes/create'])
  }


}
