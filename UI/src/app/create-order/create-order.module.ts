import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateOrderDeskComponent } from './create-order-desk/create-order-desk.component';
import { CreateOrderTabComponent } from './create-order-tab/create-order-tab.component';
import { CreateOrderMobComponent } from './create-order-mob/create-order-mob.component';



@NgModule({
  declarations: [CreateOrderDeskComponent, CreateOrderTabComponent, CreateOrderMobComponent],
  imports: [
    CommonModule
  ]
})
export class CreateOrderModule { }
