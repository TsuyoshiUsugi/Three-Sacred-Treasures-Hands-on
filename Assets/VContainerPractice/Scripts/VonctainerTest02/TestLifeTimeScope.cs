using Denik.VContainerPractice.Answer1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class TestLifeTimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<HelloWorldService>(Lifetime.Singleton);
        builder.Register<TestPresenter>(Lifetime.Singleton);
        builder.RegisterEntryPoint<GamePresenter>();
    }
}
