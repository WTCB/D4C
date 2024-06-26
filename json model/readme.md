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
Property URI's should point towards resources structured adhering ISO 23386.
Properties related to LCA data must be structured following ISO 22057.

## List of fields

| Field                         | DataType     | Cardinality     | Description  
|-------------------------------|--------------|-----------------|-----------------|
| id                            | URL          | 1..1            | Identifier of the object (url that returns the data)                                                      |
| label [rdfs]                  | string       | 1..1            | String that defines the human readable label                                                              |
| equivalentClass [owl]         | URL          | 0..n                | Property which connects an object to another object (e.g., classification, IFC, ...)                      |
| referenceunittype [iso 22057]         | string          | 1..1                | Specify if the unit is a declared unit or a functional unit                      |
| referencequantityarea [iso 22057]    | real                 | 0..1 | area quantity of a construction product for use as a reference unit in an EPD for an environmental declaration based on one or more information modules
| referencequantityitem [iso 22057]   | string                 | 0..1 | an item, an assemblage of items
| referencequantitylength [iso 22057]    | real                 | 0..1 | length quantity of a construction product for use as a reference unit in an EPD for an environmental declaration based on one or more information modules
| referencequantitymass [iso 22057]    | real                 | 0..1 | mass quantity of a construction product for use as a reference unit in an EPD for an environmental declaration based on one or more information modules
| referencequantityvolume [iso 22057]    | real                 | 0..1 |volume quantity of a construction product for use as a reference unit in an EPD for an environmental declaration based on one or more information modules


The other key/value pairs are added dynamically. The key contains the URI of the property. The value contains the value (boolean, number, string, ...) of the property.
