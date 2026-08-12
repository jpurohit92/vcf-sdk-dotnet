# Vcenter.ViJson.OpenApi.Model.DpVSphereDataProtectionCapabilitiesEnum
Enumeration of vSphere Data Protection capabilities (features).  Possible values: - `QueryPeInfo`: Support for QueryProtectedEntityInfo API.      Required minimal ESX vmodl   version: '7.0.3.0'. - `PerDiskBaseSnapshotId`: Support for specifying per-disk base-snapshot ID when taking a vSphere   Data Protection snapshot.      Required minimal ESX vmodl version: '8.0.0.1'. - `QuiescedSnapshot`: Support for vSphere Data Protection application consistent and quiesced   snapshots.      Required minimal ESX vmodl version: '8.0.1.0'. - `RuntimeStats`: Support for querying DPD runtime stats with the QueryProtectedEntityInfo   API.      Required minimal ESX vmodl version: '8.0.1.0'. - `PreservedExtents`: Support for DataIntegrity specific params (v1) when taking vSphere Data   Protection snapshots.      Required minimal ESX vmodl version: '8.0.1.0', and   ESX version of '8.0.1' and patch level of at least '0.25'. - `MultiPe`: Support for multi-PE consistency groups.      Required minimal ESX vmodl   version: '8.0.2.0'. - `VsanNativeSnapshot`: Support for VSAN native snapshots.      Required minimal ESX vmodl version:   '8.0.3.0'. - `SparseDiskEnhancement`: Enhancement for vSphere Data Protection operations over sparse disks.      Required minimal ESX vmodl version: '8.0.3.0'. - `VSphereDpCapabilities_Unknown`: Fallback value for an unknown VSphereDataProtectionCapabilities seen   by a client.    ***Since:*** 8.0.0.4 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

