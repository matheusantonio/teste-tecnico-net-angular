import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/@shared/services/usuarios.service';

@Component({
    selector: 'lista-de-usuarios',
    templateUrl: './lista-de-usuarios.component.html',
    styleUrls: ['./lista-de-usuarios.component.scss']
})
export class ListaDeUsuariosComponent implements OnInit {

    public usuarios: Array<any> = [];

    constructor(private service : UsuarioService) {}

    ngOnInit() {

        this.service.obterTodos().subscribe(resultado => {
            this.usuarios = resultado;
        });
        
    }
    
}
