import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Medicine } from '../medicine.model';

@Component({
  selector: 'view-medicine',
  templateUrl: './view-medicine.component.html',
})
export class ViewMedicineComponent {
  medicine: Medicine;
  saveMedicine() {
    // To do
  }
  clearForm() {
    this.medicine.name = "";
    this.medicine.id = 0;
    this.medicine.brand = "";
    this.medicine.price = 0.00;
    this.medicine.quantity = 0;
    this.medicine.expiryDate = null;
    this.medicine.notes = "";
  }
}
