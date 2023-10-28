using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer.Unity;

public class TestPresenter : ITickable
{
    readonly HelloWorldService _helloWorldService;

    public TestPresenter(HelloWorldService helloWorldService)
    {
        _helloWorldService = helloWorldService;
    }

    public void Tick()
    {
        _helloWorldService.Hello();
    }
}
