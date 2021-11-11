import { environment } from './../../../environments/environment';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { from, Observable, of } from 'rxjs';
import { tap } from 'rxjs/operators';
import { IfStmt } from '@angular/compiler';

@Injectable({
    providedIn: "root"
})
export class UsuarioService {

    constructor(private http : HttpClient) {}

    /*public pesquisar(nome : string, pagina : number, limite: number) : Observable<any> {

        let httpParams = new HttpParams();

        if(nome) httpParams = httpParams.append('nome', nome);
        if(pagina) httpParams = httpParams.append('pagina', pagina.toString());
        if(limite) httpParams = httpParams.append('limite', limite.toString());


        return this.http.get<any>(environment.api + "produto", {params : httpParams});
    }*/

    public obterTodos(texto: string, escolaridades: Array<number>, pagina: number, limite: number) : Observable<any> {

        let httpParams = new HttpParams();

        if(texto) httpParams = httpParams.append('texto', texto);

        if(escolaridades.length>0) {
            escolaridades.forEach(escolaridade => {
                httpParams = httpParams.append('escolaridades', escolaridade);
            });
        }
        
        if(pagina) httpParams = httpParams.append('pagina', pagina);
        if(limite) httpParams = httpParams.append('limite', limite);

        return this.http.get<any>(environment.apiUrl + "usuario/", { params: httpParams });
    }

    public obter(id : number) : Observable<any> {
        return this.http.get<any>(environment.apiUrl + "usuario/" + id);
    }

    public adicionar(usuario : any) : Observable<any> {
        return this.http.post<any>(environment.apiUrl + "usuario", usuario);
    }

    public alterar(usuario : any) : Observable<any> {
        return this.http.put<any>(environment.apiUrl + "usuario", usuario);
    }

    public remover(usuario : any) : Observable<any> {
        return this.http.delete<any>(environment.apiUrl  + "usuario/" + usuario.id);
    }

}