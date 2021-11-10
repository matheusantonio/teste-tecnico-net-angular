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
        
    }
    
}
