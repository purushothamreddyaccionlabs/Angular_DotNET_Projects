import { IPropertyBase } from "./ipropertybase";

export class Property implements IPropertyBase{
  Id!: number;
  SellRent!: number;
  Name!: string;
  PType!: string;
  BHK!: number;
  FType!: string;
  Price!: number;
  BuiltArea!: number;
  CarpetArea?:number;
  Address!: string;
  Address2?:string;
  City!: string;
  FloorNo?:string;
  TotalFloor?:number;
  RTM!: number;
  AOP?:string;
  Maintenance?:string;
  Security?:number;
  Gated?:number;
  MainEntrance?:number;
  PossessionOn?:string;
  Image?: string;
  Description?:string;
  PostedOn!: string;
  PostedBy?:number;
}
