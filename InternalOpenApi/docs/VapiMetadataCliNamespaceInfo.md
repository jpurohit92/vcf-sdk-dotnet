# Vcenter.Automation.OpenApi.Model.VapiMetadataCliNamespaceInfo
The Vapi.Metadata.Cli.Namespace.Info schema contains information about a namespace. It includes the identity of the namespace, a description, information children namespaces.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identity** | [**VapiMetadataCliNamespaceIdentity**](VapiMetadataCliNamespaceIdentity.md) | Basic namespace identity. | 
**Description** | **string** | The text description displayed to the user in help output. | 
**Children** | [**List&lt;VapiMetadataCliNamespaceIdentity&gt;**](VapiMetadataCliNamespaceIdentity.md) | The children of this namespace in the tree of CLI namespaces. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

