import { Injectable } from '@angular/core';
import { ComponentCanDeactivate } from './can-deactivate';
import { CanDeactivate } from '@angular/router';

@Injectable()
export class CanDeactivateGuard implements CanDeactivate<ComponentCanDeactivate> {
    canDeactivate(component: ComponentCanDeactivate): boolean {
        if (!component.canDeactivate()) {
            if (confirm('You have unsaved changes! If you leave, your changes will be lost.')) {
                return true;
            } else {
                return false;
            }
        }
        return true;
    }
}
