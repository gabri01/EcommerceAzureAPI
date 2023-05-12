import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { OrdineService } from 'src/app/services/ordine.service';

@Component({
  selector: 'app-ordini',
  templateUrl: './ordini.component.html',
  styleUrls: ['./ordini.component.css']
})
export class OrdiniComponent {


  constructor(private router: Router, private ordineService: OrdineService) { }
  ordList: any;

  ngOnInit()
  {
    this.getAllOrdini();
  }

  async getAllOrdini() {
    //Get data from database
    this.ordList = [];
    this.ordineService.getOrdini().subscribe((data)  => {
          this.ordList = data;
          console.log(this.ordList)
    },
    (error : any)=> {
        if (error) {
          if (error.status == 404) {
            if(error.error && error.error.message){
              this.ordList = [];
            }
          }
        }
    });
  }
}

