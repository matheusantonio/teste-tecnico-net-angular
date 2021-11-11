import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import { UsuarioService } from 'src/app/@shared/services/usuarios.service';
import { PaginatedList } from 'src/app/@shared/models/paginatedList.model';

@Component({
    templateUrl: './usuarios.component.html',
    styleUrls: ['./usuarios.component.scss']
})
export class UsuariosComponent implements OnInit {

    public usuarios: PaginatedList<any> = new PaginatedList();

    public usuarioSelecionado: any = null;

    public criandoUsuario: boolean = false;

    public loading = true;

    public filtros: any = {}

    constructor(private service : UsuarioService) {}

    ngOnInit() {
        this.filtros = {
            texto: null,
            escolaridade: []
        }
        this.carregarUsuarios();
    }

    public novoUsuario() {
        this.usuarioSelecionado = null;
        this.criandoUsuario = true;

    }

    public selecionarUsuario(usuario: any) {
        this.usuarioSelecionado = usuario;
        this.criandoUsuario = false;
    }

    public carregarUsuarios(): void {
        this.loading = true;
        this.usuarioSelecionado = null;
        this.criandoUsuario = false;

        this.service.obterTodos(this.filtros.texto, this.filtros.escolaridade, this.usuarios.pagina, this.usuarios.limite).subscribe(resultado => {
            this.usuarios.load(resultado);
            this.loading = false;
        });
    }

    public recarregarUsuarios(): void {
        this.usuarios.clear();
        this.carregarUsuarios();
    }

    public proximo(): void {
        this.usuarios.next();
        this.carregarUsuarios();
    }

    public anterior(): void {
        this.usuarios.previous();
        this.carregarUsuarios();
    }

    public get eUltimaPagina(): boolean {
        return this.usuarios.pagina == Math.ceil(this.usuarios.total / this.usuarios.limite) -1 || 
                this.usuarios.total <= this.usuarios.limite;
    }

    public get ePrimeiraPagina(): boolean {
        return this.usuarios.pagina == 0;
    }

}
