import { ErrorHandler, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';  

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from './@shared/shared.module';
import { UsuariosModule } from './usuarios/usuarios.module';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { LoadingBarModule } from '@ngx-loading-bar/core';
import { LoadingBarHttpClientModule } from '@ngx-loading-bar/http-client';
import { UsuariosErrorHandler } from './@shared/error/error.handler';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule,
    UsuariosModule,
    LoadingBarModule,
    LoadingBarHttpClientModule,
  ],
  providers: [
    { provide: ErrorHandler, useClass: UsuariosErrorHandler }, 
    { provide: MAT_DATE_LOCALE, useValue: 'pt-Br' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
