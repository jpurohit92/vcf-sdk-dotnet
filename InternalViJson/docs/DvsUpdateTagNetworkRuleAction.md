# Vcenter.ViJson.OpenApi.Model.DvsUpdateTagNetworkRuleAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QosTag** | **int** | QOS tag.  IEEE 802.1p supports 3 bit Priority Code Point (PCP). The valid values are between 0-7. Please refer the IEEE 802.1p documentation for more details about what each value represents. If qosTag is set to 0 then the tag on the packets will be cleared.  | [optional] 
**DscpTag** | **int** | DSCP tag.  The valid values for DSCP tag can be found in &#39;Differentiated Services Field Codepoints&#39; section of IANA website. The information can also be got from reading all of the below RFC: RFC 2474, RFC 2597, RFC 3246, RFC 5865. If the dscpTag is set to 0 then the dscp tag on packets will be cleared.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

