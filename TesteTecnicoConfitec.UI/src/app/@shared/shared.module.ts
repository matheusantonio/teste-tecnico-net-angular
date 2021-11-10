import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatToolbarModule } from '@angular/material/toolbar';
import { UsuarioService } from './services/usuarios.service';

@NgModule({
  imports:[
    HttpClientModule,
  ],
  declarations: [
  ],
  exports: [
      MatCardModule,
      MatToolbarModule,
      HttpClientModule,
  ],
})
export class SharedModule { }