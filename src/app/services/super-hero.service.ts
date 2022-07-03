import { Injectable } from '@angular/core';
import { SuperHero } from '../models/super-hero';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroService {

  constructor() { }

  public getSuperHeroes() : SuperHero[] {
    let hero = new SuperHero();
    hero.id = 1;
    hero.name = "Spiper Man";
    hero.firstName = "Spider";
    hero.lastName = "Parker";
    hero.place = "New York City";

    return [hero];
  }
}
