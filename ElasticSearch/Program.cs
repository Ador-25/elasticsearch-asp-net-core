﻿
// imports
using ElasticSearch.Services;

// hosts and indexes
string host = "http://localhost:9200";
string indexName = "product-index";


IElasticSearchService service = new ElasticSearchService();

// create index
service.CreateIndex(host, indexName);


// insert data to index