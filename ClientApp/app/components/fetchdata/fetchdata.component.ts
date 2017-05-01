import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import {Router } from '@angular/router'
import {ProductService } from '../../services/product.service'

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchProductComponent implements OnInit {
    public products: Product[];
    errorMessage: string;

    constructor(private _router:Router, private _service: ProductService) {           
    }

    ngOnInit()
    {
        this._service.getAll().subscribe((data: Product[]) => this.products = data,error=>this.errorMessage=<any>error);
    }
}


