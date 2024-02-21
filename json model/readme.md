# D4C Data model
This page will document the JSON schema for the exchange protocol

## Table of contents:
- [D4C Data model](#d4c-data-model)
  - [Table of contents:](#table-of-contents)
  - [Used ontologies](#used-ontologies)
  - [Conventions](#conventions)
    - [Product URI's](#product-uris)
    - [Property URI's](#property-uris)
  - [List of fields](#list-of-fields)
  
## Used ontologies
The protocol uses existing ontologies instead of creating new ones. A list of used ontologies
  * owl: http://www.w3.org/2002/07/owl#
  * rdfs: http://www.w3.org/2000/01/rdf-schema#

## Conventions
### Product URI's
Product URI's should not have spaces nor frontslashes
### Property URI's
Property URI's should point towards resources structured adhering ISO 23386

## List of fields

| Field                         | DataType     | Cardinality     | Description                                                                                               |
|-------------------------------|--------------|-----------------|-----------------------------------------------------------------------------------------------------------|
| id                            | URL          | 1..1            | Identifier of the object (url that returns the data)                                                      |
| label [rdfs]                  | string       | 1..1            | String that defines the human readable label                                                              |
| equivalentClass [owl]         | URL          |                 | Property which connects an object to another object (e.g., classification, IFC, ...)                      |

The other key/value pairs are added dynamically. The key contains the URI of the property. The value contains the value (boolean, number, string, ...) of the property.