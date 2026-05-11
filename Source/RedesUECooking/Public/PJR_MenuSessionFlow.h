// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "PJR_MenuSessionFlow.generated.h"

UCLASS()
class REDESUECOOKING_API APJR_MenuSessionFlow : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	APJR_MenuSessionFlow();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;
	UPROPERTY(VisibleAnywhere)
	TObjectPtr<UMiComponenteA> ComponenteA;


public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

};
