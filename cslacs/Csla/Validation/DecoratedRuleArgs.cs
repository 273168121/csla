using System;
using System.Collections.Generic;
using System.Text;

namespace Csla.Validation
{
  /// <summary>
  /// Object providing extra information to methods that
  /// implement business rules.
  /// </summary>
  public class DecoratedRuleArgs : RuleArgs
  {
    private Dictionary<string, object> _decorations;

    #region Base Constructors

    /// <summary>
    /// Creates an instance of RuleArgs.
    /// </summary>
    /// <param name="propertyName">The name of the property to be validated.</param>
    public DecoratedRuleArgs(string propertyName)
      : base(propertyName)
    {
      _decorations = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates an instance of RuleArgs.
    /// </summary>
    /// <param name="propertyName">The name of the property to be validated.</param>
    /// <param name="severity">Initial default severity for the rule.</param>
    /// <remarks>
    /// <para>
    /// The <b>severity</b> parameter defines only the initial default 
    /// severity value. If the rule changes this value by setting
    /// e.Severity, then that new value will become the default for all
    /// subsequent rule invocations.
    /// </para><para>
    /// To avoid confusion, it is recommended that the 
    /// <b>severity</b> constructor parameter 
    /// only be used for rule methods that do not explicitly set
    /// e.Severity.
    /// </para>
    /// </remarks>
    public DecoratedRuleArgs(string propertyName, RuleSeverity severity)
      : base(propertyName, severity)
    {
      _decorations = new Dictionary<string, object>();
    }

    /// <summary>
    /// Creates an instance of RuleArgs.
    /// </summary>
    /// <param name="propertyName">The name of the property to be validated.</param>
    /// <param name="severity">The default severity for the rule.</param>
    /// <param name="stopProcessing">
    /// Initial default value for the StopProcessing property.
    /// </param>
    /// <remarks>
    /// <para>
    /// The <b>severity</b> and <b>stopProcessing</b> parameters 
    /// define only the initial default values. If the rule 
    /// changes these values by setting e.Severity or
    /// e.StopProcessing, then the new values will become 
    /// the default for all subsequent rule invocations.
    /// </para><para>
    /// To avoid confusion, It is recommended that the 
    /// <b>severity</b> and <b>stopProcessing</b> constructor 
    /// parameters only be used for rule methods that do 
    /// not explicitly set e.Severity or e.StopProcessing.
    /// </para>
    /// </remarks>
    public DecoratedRuleArgs(string propertyName, RuleSeverity severity, bool stopProcessing)
      : base(propertyName, severity, stopProcessing)
    {
      _decorations = new Dictionary<string, object>();
    }

    #endregion

    /// <summary>
    /// Creates an instance of RuleArgs.
    /// </summary>
    /// <param name="propertyName">The name of the property to be validated.</param>
    /// <param name="args">Reference to a Dictionary containing 
    /// name/value arguments for use by the rule method.</param>
    public DecoratedRuleArgs(string propertyName, Dictionary<string,object> args)
      : base(propertyName)
    { 
      _decorations = args;
    }

    /// <summary>
    /// Creates an instance of RuleArgs.
    /// </summary>
    /// <param name="propertyName">The name of the property to be validated.</param>
    /// <param name="severity">Initial default severity for the rule.</param>
    /// <remarks>
    /// <para>
    /// The <b>severity</b> parameter defines only the initial default 
    /// severity value. If the rule changes this value by setting
    /// e.Severity, then that new value will become the default for all
    /// subsequent rule invocations.
    /// </para><para>
    /// To avoid confusion, it is recommended that the 
    /// <b>severity</b> constructor parameter 
    /// only be used for rule methods that do not explicitly set
    /// e.Severity.
    /// </para>
    /// </remarks>
    /// <param name="args">Reference to a Dictionary containing 
    /// name/value arguments for use by the rule method.</param>
    public DecoratedRuleArgs(string propertyName, RuleSeverity severity, Dictionary<string, object> args)
      : base(propertyName, severity)
    { 
      _decorations = args;
    }

    /// <summary>
    /// Creates an instance of RuleArgs.
    /// </summary>
    /// <param name="propertyName">The name of the property to be validated.</param>
    /// <param name="severity">The default severity for the rule.</param>
    /// <param name="stopProcessing">
    /// Initial default value for the StopProcessing property.
    /// </param>
    /// <remarks>
    /// <para>
    /// The <b>severity</b> and <b>stopProcessing</b> parameters 
    /// define only the initial default values. If the rule 
    /// changes these values by setting e.Severity or
    /// e.StopProcessing, then the new values will become 
    /// the default for all subsequent rule invocations.
    /// </para><para>
    /// To avoid confusion, It is recommended that the 
    /// <b>severity</b> and <b>stopProcessing</b> constructor 
    /// parameters only be used for rule methods that do 
    /// not explicitly set e.Severity or e.StopProcessing.
    /// </para>
    /// </remarks>
    /// <param name="args">Reference to a Dictionary containing 
    /// name/value arguments for use by the rule method.</param>
    public DecoratedRuleArgs(string propertyName, RuleSeverity severity, bool stopProcessing, Dictionary<string, object> args)
      : base(propertyName, severity, stopProcessing)
    { 
      _decorations = args;
    }

    /// <summary>
    /// Gets or sets an argument value for use
    /// by the rule method.
    /// </summary>
    /// <param name="key">The name under which the value is stored.</param>
    /// <returns></returns>
    public object this[string key]
    {
      get { return _decorations[key]; }
      set { _decorations[key] = value; }
    }
  }
}
