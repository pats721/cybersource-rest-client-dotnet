# CyberSource.Model.InvoicingV2InvoicesAllGet200Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**InlineResponse200Links**](InlineResponse200Links.md) |  | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; **Example** &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  Returned by Cybersource for all services.  | [optional] 
**TotalInvoices** | **int?** |  | [optional] 
**Invoices** | [**List&lt;InvoicingV2InvoicesAllGet200ResponseInvoices&gt;**](InvoicingV2InvoicesAllGet200ResponseInvoices.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

