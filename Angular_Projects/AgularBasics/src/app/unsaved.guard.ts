import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanDeactivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { SearchComponent } from 'src/search/search.component';

@Injectable({
  providedIn: 'root'
})
export class UnsavedGuard implements CanDeactivate<SearchComponent> {
  canDeactivate(
    component: SearchComponent){
      if(component.isDirty){
        return window.confirm("You have some unsaved changes are you want to go back still");
      }
      return true;
  }
  
}
