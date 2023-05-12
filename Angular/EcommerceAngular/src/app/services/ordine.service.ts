import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class OrdineService {

  apiRootPath = 'https://localhost:7287';

  constructor(private httpClient: HttpClient, private router: Router) { };

  getOrdini() {
    const url = this.apiRootPath + '/api/Ordine/Ordini';
    console.log('OrdineService getOrdines UrlAPI: ' + url);  
    console.log(localStorage.getItem('token'));
   return this.httpClient.get(url, { 
    headers: new HttpHeaders(
    {
      'Authorization': 'Bearer ' + localStorage.getItem('token'),
       'Content-Type': 'application/json'
    }),
    responseType: "json"
  });
  }
}
