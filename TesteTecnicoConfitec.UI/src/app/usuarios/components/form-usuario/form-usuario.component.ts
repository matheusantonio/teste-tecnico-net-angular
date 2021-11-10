import { Component, EventEmitter, Input, OnChanges, OnInit, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';
import { UsuarioService } from 'src/app/@shared/services/usuarios.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AlterarUsuario, RegistrarUsuario } from 'src/app/@shared/commands/usuarios.command';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
    selector: 'form-usuario',
    templateUrl: './form-usuario.component.html',
    styleUrls: ['./form-usuario.component.scss']
})
export class FormUsuarioComponent implements OnChanges {

    @Input()
    public usuario: any = {}

    @Input()
    public modoEdicao: boolean = false;

    @Output()
    public refresh: EventEmitter<any> = new EventEmitter<any>();

    public form : FormGroup = this.builder.group({});

    public loading = true;

    constructor(
        private service : UsuarioService, 
        private builder: FormBuilder, 
        private _snackBar: MatSnackBar) {}

    ngOnChanges() {
        if(this.modoEdicao) {
            this.service.obter(this.usuario.id).subscribe(result => {
                this.criarFormulario(result);
                this.loading = false;
            });
        } else {
            this.criarFormulario();
            this.loading = false;
        }
        
    }

    private criarFormulario(usuario:any = null) {
        this.form = this.builder.group({
            id: [usuario?.id],
            nome: [usuario?.nome, Validators.required],
            sobrenome: [usuario?.sobrenome, Validators.required],
            email: [usuario?.email, [Validators.required, Validators.email]],
            dataDeNascimento: [usuario?.dataDeNascimento, Validators.required],
            escolaridade: [usuario?.escolaridade.toString(), Validators.required]
        });
    }

    public salvar(): void {
        let usuario = this.form.value;
        usuario.escolaridade = +usuario.escolaridade;

        if(this.modoEdicao){
            let cmd = new AlterarUsuario(usuario);
            this.service.alterar(cmd).subscribe(result => {
                this._snackBar.open("Usuário alterado com sucesso", "Fechar", { duration: 3000 })
                this.refresh.emit();
            });
        } else {
            let cmd = new RegistrarUsuario(usuario);
            this.service.adicionar(cmd).subscribe(result => {
                this._snackBar.open("Usuário criado com sucesso", "Fechar", { duration: 3000 })
                this.refresh.emit();
            });
        }
        
    }
    
    public excluir(): void {
        this.service.remover(this.usuario.id).subscribe(result => {
            this._snackBar.open("Usuário removido com sucesso", "Fechar", { duration: 3000 })
            this.refresh.emit();
        })
    }
}
