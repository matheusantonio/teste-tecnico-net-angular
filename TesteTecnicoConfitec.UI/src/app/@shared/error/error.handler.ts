import { MatSnackBar } from '@angular/material/snack-bar';
import { ErrorHandler, Injectable, Injector } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable()
export class UsuariosErrorHandler implements ErrorHandler {

    constructor(private injector: Injector) { }

    handleError(error: Error | HttpErrorResponse) {

        const notifier = this.injector.get(MatSnackBar);

        if (error instanceof HttpErrorResponse) {

            if (!navigator.onLine) {
                return notifier.open('Sem conexão', "Fechar", { duration: 3000 });
            }

            let errorMsg = error.error.message || error.message;
            return notifier.open(errorMsg, "Fechar", { duration: 3000 });

        } else {
            console.error(error);
            return notifier.open(error.message, "Fechar", { duration: 3000 });
        }
    }
}