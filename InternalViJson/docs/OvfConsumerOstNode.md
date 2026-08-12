# Vcenter.ViJson.OpenApi.Model.OvfConsumerOstNode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The OVF id of the Content (VirtualSystem or VirtualSystemCollection) element.  Empty on the envelope node.  | 
**Type** | **string** | The type of the node.  Possible values are defined in the OstNodeType enum.  Since the OstNode tree structure mirrors the structure of the OVF descriptor, only one Envelope node is defined, and it is always the root of the tree.  | 
**Section** | [**List&lt;OvfConsumerOvfSection&gt;**](OvfConsumerOvfSection.md) | The list of sections on this node.  | [optional] 
**Child** | [**List&lt;OvfConsumerOstNode&gt;**](OvfConsumerOstNode.md) | The list of child nodes.  As dictated by OVF, this list is subject to the following rules: - The Envelope node must have exactly one child. - VirtualSystemCollection nodes may have zero or more children. - VirtualSystem nodes must have no children.  | [optional] 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The VM or vApp corresponding to this node.  This field is set when this OstNode represents an existing managed entity.  The entity is unset on nodes of type OstNodeType.envelope.  Refers instance of *ManagedEntity*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

