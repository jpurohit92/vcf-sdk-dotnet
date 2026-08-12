# Vcenter.ViJson.OpenApi.Model.VsanCompositeConstraint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetType** | **string** | The type of the resources targeted by this constraint.  If a value is not specified, the constraint will match all resource types.  Note that explicitly setting the &lt;code&gt;targetType&lt;/code&gt; property may lead to a more optimal processing of the data request.  | [optional] 
**NestedConstraints** | [**List&lt;VsanResourceConstraint&gt;**](VsanResourceConstraint.md) | The nested or sub-constraints that this composite is made of.  Note that the order of the constraints in the array is important when the operator is not commutative, e.g. *EXCEPT*.  | [optional] 
**Conjoiner** | **string** | The operator to be used to join the resource sets identified by the nested constraints.  See *VsanCompositeConstraintConjoinerEnum_enum* for possible conjoiner operators.  See also *VsanCompositeConstraintConjoinerEnum_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

