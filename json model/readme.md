# D4C Data model
This page will document the JSON schema for the exchange protocol

## Table of contents:
* [Conventions](#conventions)
* [Used ontologies](#used-ontologies)
* [List of fields](#list-of-fields)
  * [Object](#object)
  * [Property](#property)
  * [Relation](#relation)
  * [Unit](#unit)
  
## Used ontologies
The protocol uses existing ontologies instead of creating new ones. A list of used ontologies
  * owl: https://www.w3.org/2002/07/owl
  * rdf: http://www.w3.org/1999/02/22-rdf-syntax-ns

## Conventions
### Product URI's
Product URI's should not have spaces nor frontslashes
### Property URI's
Property URI's should point towards resources structured adhering ISO 23386

## List of fields

| Field | DataType | Cardinality | Description | Path |
|----------|----------|----------|----------|----------|
| @context | URI | 1 | url (https://raw.githubusercontent.com/WTCB/D4C/main/Model/schema.jsonld) pointing to the schema definition | @context |
| object                        | [Object](#object) | 1..* |  |  |