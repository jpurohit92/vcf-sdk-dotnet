# Vcenter.ViJson.OpenApi.Model.ClusterDrsRecommendation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key to identify the recommendation when calling applyRecommendation.  | 
**Rating** | **int** | A rating of the recommendation.  Valid values range from 1 (lowest confidence) to 5 (highest confidence).  | 
**Reason** | **string** | A reason code explaining why this set of migrations is being suggested.  | 
**ReasonText** | **string** | Text that provides more information about the reason code for the suggested set of migrations.  | 
**MigrationList** | [**List&lt;ClusterDrsMigration&gt;**](ClusterDrsMigration.md) | Deprecated a more general *recommendation* list should be used. This recommendation type and the migrationList is kept for backward compatibility.  List of migrations in this recommendation and all the parent recommendations on which this recommendation depends.  All the migrations in this list can be constructed from *ClusterRecommendation.prerequisite* and *ClusterRecommendation.action*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

