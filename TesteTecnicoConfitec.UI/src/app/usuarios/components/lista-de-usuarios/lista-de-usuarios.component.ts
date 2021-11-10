import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { UsuarioService } from 'src/app/@shared/services/usuarios.service';

@Component({
    selector: 'lista-de-usuarios',
    templateUrl: './lista-de-usuarios.component.html',
    styleUrls: ['./lista-de-usuarios.component.scss']
})
export class ListaDeUsuariosComponent implements OnInit {

    @Input()
    public usuarios: Array<any> = [];

    @Output() usuarioSelecionado: EventEmitter<any> = new EventEmitter<any>();

    constructor() {}

    ngOnInit() {

        
        
    }

    public selecionarUsuario(usuario: any): void {
        this.usuarioSelecionado.emit(usuario);
    }
    
}
