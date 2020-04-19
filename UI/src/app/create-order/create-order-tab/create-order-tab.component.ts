import { Component, OnInit } from '@angular/core';
import { CreateOrder } from '../create-order';

@Component({
  selector: 'app-create-order-tab',
  templateUrl: './create-order-tab.component.html',
  styleUrls: ['./create-order-tab.component.scss']
})
export class CreateOrderTabComponent extends CreateOrder implements OnInit {

  constructor() {super(); }

  ngOnInit(): void {
    
  }

}
