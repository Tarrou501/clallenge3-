import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { Cliente } from '../cliente.model';
import { ClienteRead2DataSource } from './cliente-read2-datasource';

@Component({
  selector: 'app-cliente-read2',
  templateUrl: './cliente-read2.component.html',
  styleUrls: ['./cliente-read2.component.css']
})
export class ClienteRead2Component implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<Cliente>;
  dataSource: ClienteRead2DataSource;

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['id', 'nome','sobrenome'];

  constructor() {
    this.dataSource = new ClienteRead2DataSource();
  }

  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }
}