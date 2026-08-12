# Vcenter.ViJson.OpenApi.Model.VsanDataEncryptionConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EncryptionEnabled** | **bool** | Is data encryption enabled on the cluster? Enabling encryption on a cluster will proceed to encrypt all the hosts.  Progress of this can be tracked by the changing flag and the reconfigure task. Disabling encryption, will expose all previously encrypted data in the clear.  | 
**KmsProviderId** | [**KeyProviderId**](KeyProviderId.md) | The Id of the KMS cluster to use for vSAN Encryption.  Keys will be created on and used from this KMS. This parameter is ignored if encryption is disabled. It must be set to a valid KMS cluster ID if encryption is enabled. When it is already an encrypted vSAN cluster and a different value of kmsProviderId is provided, it will switch to the new KMS cluster as specified by new kmsProviderId. A new KEK Id will also be created in the new KMS cluster and a shallow rekey is performed to use the new KEK. See *CryptoManagerKmip.kmipServers* and *KmipClusterInfo*  | [optional] 
**KekId** | **string** | The KEK Id of the KMS cluster to use.  Do not set a key&#39;s Id for this when reconfiguring vSAN encryption, because such key will be created automatically from key management server. There is rare use case to put a valid key Id here, for example, when restoring configuration for the cluster from existing running hosts.  | [optional] 
**HostKeyId** | **string** | The Id of host key which is used for host core dump encryption.  Do not set this value when reconfiguring vSAN encryption, because such key will be created automatically from key management server.  | [optional] 
**DekGenerationId** | **long** | DEK generation number of the vSAN cluster.  Do not set a generation number for this when reconfiguring vSAN encryption because such a field will be created and managed automatically by vSAN.  | [optional] 
**Changing** | **bool** | Whether Encryption has finished enabling or disabling operation.  When changing is true, then encryption has not finished enabling or disabling. Changing will become false once all hosts currently in the cluster have adapted to the current setting of encryptionEnabled. No guarantee can be made that all data will be encrypted until changing is false and encryptionEnabled is true. This value can be read, but should never be set by API callers Reconfiguring a cluster.  | [optional] 
**EraseDisksBeforeUse** | **bool** | Whether disks should be wiped when a normal disk is converted to encrypted disk, or a disk is claimed as encrypted disk, or a disk runs deep rekey.  If set true, every sector on a disk will be written with random data. Disk wipe does significantly reduce the possibility of data leak and increases the attacker&#39;s cost to reveal sensitive data. The disadvantage of disk wipe is that it takes a long time to finish, so turn it on through UI or API only when necessary. If not set, disk won&#39;t be wiped.  | [optional] 
**WrappedDek** | **string** | Data Encryption Key (DEK) wrapped by Key Encryption Key (KEK).  | [optional] 
**DekId** | **string** | UUID of cluster wide Data Encryption Key (DEK).  | [optional] 
**OldWrappedDek** | **string** | Old Data Encryption Key (DEK) wrapped by Key Encryption Key (KEK).  | [optional] 
**OldDekId** | **string** | UUID of the old cluster wide Data Encryption Key (DEK).  | [optional] 
**KekVerifier** | **string** | Verifier of KEK.  It&#39;s calculated by encrypting all zero data with KEK. ESX host can verify KEK correctness using this verifier.  | [optional] 
**DekVerifier** | **string** | Verifier of DEK.  It&#39;s calculated by encrypting all zero data with DEK. ESX host can verify DEK correctness using this verifier.  | [optional] 
**OldDekVerifier** | **string** | Verifier of old DEK.  It&#39;s calculated by encrypting all zero data with old DEK. ESX host can verify old DEK correctness using this verifier.  | [optional] 
**Iv** | **string** | Initialization vector used by encryption algorithm.  The vector is encoded as a string.  | [optional] 
**Syncing** | **bool** | Whether the cluster is syncing encryption config when it enables encryption or does deep rekey.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

