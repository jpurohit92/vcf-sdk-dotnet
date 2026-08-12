# Vcenter.ViJson.OpenApi.Model.VsanPropertyConstraint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetType** | **string** | The type of the resources targeted by this constraint.  If a value is not specified, the constraint will match all resource types.  Note that explicitly setting the &lt;code&gt;targetType&lt;/code&gt; property may lead to a more optimal processing of the data request.  | [optional] 
**PropertyName** | **string** | The name of the resource model property to be evaluated by this constraint.  For example: &lt;code&gt;runtime.host&lt;/code&gt;.  If a value is not specified, i.e., &lt;code&gt;null&lt;/code&gt; the constraint will evaluate all properties of the kind implied by the interpretation context, e.g., if used in a &lt;code&gt;PropertyConstraint&lt;/code&gt; with the operator *TEXTUALLY_MATCHES*, it&#39;d imply all textual properties.  | [optional] 
**Comparator** | **string** | Defines the possible operators to use for comparison of the resource model properties.  See also *VsanPropertyConstraintComparatorEnum_enum*.  | [optional] 
**ComparableValue** | [**KeyAnyValue**](KeyAnyValue.md) | The value to be compared against the specified resource model property.  Could be \\* an array if the comparison operator works on a range of values.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

