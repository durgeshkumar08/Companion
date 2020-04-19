import { Component, OnInit } from '@angular/core';
import { CreateOrder } from '../create-order';

@Component({
  selector: 'app-create-order-mob',
  templateUrl: './create-order-mob.component.html',
  styleUrls: ['./create-order-mob.component.scss']
})
export class CreateOrderMobComponent extends CreateOrder implements OnInit {
  
  constructor()
  {super();}

  ngOnInit(): void {
    
  }

}
