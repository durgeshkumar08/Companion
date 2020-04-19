import { Component, OnInit } from '@angular/core';
import { CreateOrder } from '../create-order';

@Component({
  selector: 'app-create-order-web',
  templateUrl: './create-order-web.component.html',
  styleUrls: ['./create-order-web.component.scss']
})
export class CreateOrderWebComponent extends CreateOrder implements OnInit {

  constructor() { super();}

  ngOnInit(): void {
  }

}
