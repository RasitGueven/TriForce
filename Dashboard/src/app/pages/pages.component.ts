import { Component } from '@angular/core';

import { MENU_ITEMS, MENU_ITEMS_SELLER, MENU_ITEMS_FIRST } from './pages-menu';
import { ScChoiceComponent } from './sc-choice/sc-choice.component';
import { AfterViewInit, OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
import { AuthService } from '../auth/auth.service';

@Component({
  selector: 'ngx-pages',
  template: `
    <ngx-sample-layout>
      <nb-menu [items]="consumer" *ngIf="true"></nb-menu>
      <nb-menu [items]="seller" *ngIf="true"></nb-menu>     
      <nb-menu [items]="first" *ngIf="true"></nb-menu> 
      <router-outlet></router-outlet>
    </ngx-sample-layout>
  `,
})
export class PagesComponent{

  isSeller : boolean;
  isFirst : boolean; 
  
  
constructor(private auth : AuthService){}

getSeller(){
  if(this.auth.email == 'seller@test.de'){
    return this.isSeller = true;
  }
}

getLogin(){
  return this.auth.exists; 
}

getFirstLogin(da : string){
  alert("in der methode 1");
  if(da.toString() == 'true'){  
    this.isFirst = true;
    alert(this.isFirst);
  } else {
    this.isFirst = false;
    alert("in der methode 3"); 
  }
  return this.isFirst; 
}

isFirstLogin(){
return this.isFirst;
}

getSC(){

  return true; 
}
  
  consumer = MENU_ITEMS;
  seller = MENU_ITEMS_SELLER;
  first = MENU_ITEMS_FIRST;
}
