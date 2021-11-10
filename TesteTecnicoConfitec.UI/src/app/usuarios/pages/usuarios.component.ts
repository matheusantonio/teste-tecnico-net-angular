import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import { UsuarioService } from 'src/app/@shared/services/usuarios.service';

@Component({
    templateUrl: './usuarios.component.html',
    styleUrls: ['./usuarios.component.scss']
})
export class UsuariosComponent implements OnInit {

    public usuarios: Array<any> = [];

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
        debugger;
        this.usuarioSelecionado = null;
        this.criandoUsuario = false;
        this.service.obterTodos(this.filtros.texto, this.filtros.escolaridade).subscribe(resultado => {
            this.usuarios = resultado;
            this.loading = false;
        });
    }
    

}
