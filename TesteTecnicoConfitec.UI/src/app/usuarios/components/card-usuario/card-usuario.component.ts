import { Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';

@Component({
    selector: 'card-usuario',
    templateUrl: './card-usuario.component.html',
    styleUrls: ['./card-usuario.component.scss']
})
export class CardUsuarioComponent implements OnInit {
    
    @Input()
    public usuario: any;
    
    ngOnInit() {
        this.usuario.escolaridade = this.mapearEscolaridade(this.usuario.escolaridade);
    }

    private mapearEscolaridade(escolaridade : number) {
        if(escolaridade == 0) return 'Infantil';
        if(escolaridade == 1) return 'Fundamental';
        if(escolaridade == 2) return 'Médio';
        if(escolaridade == 3) return 'Superior';
        return '';
    }
    
}
