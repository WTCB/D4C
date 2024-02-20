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
### Object
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URL or Text         |    1..1             | Identifier of the object (url that returns the data)                                                                                  |
| label [rdf]                     | string          | 1..1               |          string that defines the human readable label                                                                   |
| name                          | Text       | 1..*            | Name of the object                                                                                        |
| 

### Property
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| property                            | URL          | 1..n               | Identifier of the property                                                                                |
|                                                                                    |

### Relation
| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| relation [owl]                            | URL          | 1..n               | Relatable object of other dictionary                                                                                |
|


